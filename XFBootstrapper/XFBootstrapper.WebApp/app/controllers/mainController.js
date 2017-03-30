"use strict";
angular.module('app').controller('mainController', ['$scope', '$mdMedia', '$mdSidenav', '$location', '$interval', 'httpFeaturesService', 'httpAdvancedSettingsService',
    function ($scope, $mdMedia, $mdSidenav, $location, $interval, httpFeaturesService, httpAdvancedSettingsService) {

        // TODO initializing plugins and features
        $scope.$location = $location;

        $scope.theme = 'xfbootstrapper';

        $scope.close = function () {
            $mdSidenav('sidenav-left')
            .close()
            .then(function () { });
        };
        $scope.open = function () {
            $mdSidenav('sidenav-left')
            .open()
            .then(function () { });
        };
        $scope.isOpen = function () {
            return $mdSidenav('sidenav-left').isOpen();
        };

        $scope.featuresAreLoading = false;
        $scope.advancedSettingsAreLoading = false;

        $scope.$on('$locationChangeSuccess', function (ev, newUrl, oldUrl, newState, oldState) {
            var path = ev.currentScope.$location.path();

            if (path != ('/start') && !$scope.validateProjectName()) {
                $scope.changeLocation('start');
                return;
            }
            //if ((path != ('/start') || path != ('/type')) && $scope.project.type === undefined) {
            //    $scope.changeLocation('type');
            //    return;
            //}

            if (path == ('/features')) {
                if ($scope.project.features === undefined) {
                    $scope.project.features = [];
                }
                if ($scope.features === undefined) {
                    $scope.featuresAreLoading = true;
                    httpFeaturesService.getFeatures()
                    .then(function (result) {
                        $scope.features = result.data;
                        $scope.featureRows = [];
                        var featureRow = [];
                        for (var i = 1; i <= $scope.features.length; i++) {
                            featureRow.push($scope.features[i - 1]);

                            if (i % 5 == 0) {
                                $scope.featureRows.push(featureRow);
                                featureRow = [];
                            }
                        }
                        $scope.featureRows.push(featureRow);
                    }, function (error) {

                    }).then(function () {
                        $scope.featuresAreLoading = false;
                    });
                }
            }
            if (path == ('/advanced')) {
                if ($scope.project.advanced === undefined) {
                    $scope.project.advanced = [];
                }
                if ($scope.advancedSettings === undefined) {
                    $scope.advancedSettingsAreLoading = true;
                    httpAdvancedSettingsService.getAdvancedSettings()
                    .then(function (result) {
                        $scope.advancedSettings = result.data;
                        $scope.advancedSettingRows = [];
                        var advancedSettingRow = [];
                        for (var i = 1; i <= $scope.advancedSettings.length; i++) {
                            advancedSettingRow.push($scope.advancedSettings[i - 1]);

                            if (i % 5 == 0) {
                                $scope.advancedSettingRows.push(advancedSettingRow);
                                advancedSettingRow = [];
                            }
                        }
                        $scope.advancedSettingRows.push(advancedSettingRow);
                    }, function (error) {
                    }).then(function () {
                        $scope.advancedSettingsAreLoading = false;
                    });
                }
            }
        });

        $scope.changeLocation = function (routeName) {
            $location.path(routeName);
        };

        $scope.project = {
            name: undefined,
            type: undefined,
            platforms: []
        };

        $scope.getPercentComplete = function () {
            var percent = 0;

            if ($scope.validateProjectName()) { percent += 10; }
            if ($scope.project.type === 'mobile') {
                percent += 5;
                if ($scope.project.platforms !== undefined && $scope.project.platforms.length > 0) {
                    percent += 10;
                }
            } else if ($scope.project.type === 'web') {
                percent += 15;
            }
            if ($scope.project.features !== undefined) {
                percent += 70;
            }
            if ($scope.project.advanced !== undefined) {
                percent += 5;
            }

            return percent;
        };

        $scope.previousPage = function () {
            switch ($location.path()) {
                case '/start':
                    break;
                case '/type':
                    $scope.changeLocation('start');
                    break;
                case '/mobileplatform':
                    $scope.changeLocation('type');
                    break;
                case '/features':
                    if ($scope.project.type === 'mobile') {
                        $scope.changeLocation('mobileplatform');
                    } else {
                        $scope.changeLocation('type');
                    }
                    break;
                case '/advanced':
                    $scope.changeLocation('features');
                    break;
                default:

            }
        };

        $scope.nextPage = function () {
            switch ($location.path()) {
                case '/start':
                    $scope.changeLocation('type');
                    break;
                case '/type':
                    if ($scope.project.type === 'mobile') {
                        $scope.changeLocation('mobileplatform');
                    }
                    else {
                        $scope.changeLocation('features');
                    }
                    break;
                case '/mobileplatform':
                    $scope.changeLocation('features');
                    break;
                case '/features':
                    $scope.changeLocation('advanced');
                    break;
                case '/advanced':
                    $scope.changeLocation('download');
                    break;
                default:

            }
        };

        $scope.sanitizeProjectName = function () {
            if ($scope.project.name) {
                $scope.project.name = $scope.project.name.replace(" ", "_").replace(/[^a-zA-Z0-9._-]/g, '');
            }
        };
        $scope.validateProjectName = function () {
            return $scope.project.name !== undefined && $scope.project.name.length > 3;
        };

        //$scope.appIconIndex = 0;
        //$scope.webAppIcons = ['desktop_mac', 'web', 'computer'];
        //$scope.mobileAppIcons = ['phone_android', 'smartphone', 'phone_iphone'];
        //$scope.webAppIcon = $scope.webAppIcons[$scope.appIconIndex];
        //$scope.mobileAppIcon = $scope.mobileAppIcons[$scope.appIconIndex];
        //$interval(function () {
        //    $scope.appIconIndex++;
        //    if ($scope.appIconIndex >= $scope.webAppIcons.length) {
        //        $scope.appIconIndex = 0;
        //    }

        //    $scope.webAppIcon = $scope.webAppIcons[$scope.appIconIndex];
        //    $scope.mobileAppIcon = $scope.mobileAppIcons[$scope.appIconIndex];
        //}, 2000, 0);


        $scope.toggleMobilePlatform = function (platform) {
            if (platform.isEnabled) {
                platform.isChecked = !platform.isChecked;
                if (platform.isChecked) {
                    $scope.project.platforms.insert(platform);
                } else {
                    $scope.project.platforms.remove(platform);
                }
            }
        };
        $scope.mobilePlatformSource = [
            {
                id: 'iphone',
                name: 'iPhone',
                icon: 'phone_iphone',
                isEnabled: true,
                isChecked: false
            },
            {
                id: 'droid',
                name: 'Android',
                icon: 'phone_android',
                isEnabled: true,
                isChecked: false
            },
            {
                id: 'uwp',
                name: 'Windows Phone',
                icon: 'smartphone',
                isEnabled: false,
                isChecked: false
            }
        ];
    }
])