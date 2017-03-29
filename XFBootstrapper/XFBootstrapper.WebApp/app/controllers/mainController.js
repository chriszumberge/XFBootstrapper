"use strict";
angular.module('app').controller('mainController', ['$scope', '$mdMedia', '$mdSidenav', '$location',
    function ($scope, $mdMedia, $mdSidenav, $location) {

        // TODO initializing plugins and features

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

        $scope.changeLocation = function (routeName) {
            $location.path(routeName);
        };

        $scope.project = {};
        $scope.configPageIndex = 0;

        //if ($scope.project === undefined) {
        //    // Initailize the project
        //    $scope.project = {};
        //    // Set the location to the start
        //    $location.path("start");
        //}

        $scope.sanitizeProjectName = function () {
            if ($scope.project.name) {
                $scope.project.name = $scope.project.name.replace(" ", "_").replace(/[^a-zA-Z0-9._-]/g, '');
            }
        };

        // TODO I hate this.. all of it.. 
        $scope.configPages = configPages;
        $scope.currentPage = $scope.configPages[$scope.configPageIndex];
        $scope.currentPage.isActive = true;
        $scope.changeLocation($scope.currentPage.routeName);
        $scope.configValues = $scope.currentPage.configValues;

        $scope.isPreviousDisabled = $scope.currentPage.isPreviousDisabled;
        $scope.isNextDisabled = $scope.currentPage.isNextDisabled;

        // TODO have to set isValid and isActive when clicking away on the menu
        $scope.previousPage = function () {
            if ($scope.configPageIndex > 0) {
                $scope.currentPage.isActive = false;
                // if we're able to nav away, have to assume page data is valid
                //$scope.currentPage.isValid = true;
                $scope.configPageIndex--;
                $scope.currentPage = $scope.configPages[$scope.configPageIndex];
                $scope.changeLocation($scope.currentPage.routeName);
                $scope.currentPage.isActive = true;
                $scope.configValues = $scope.currentPage.configValues;
                $scope.isPreviousDisabled = $scope.currentPage.isPreviousDisabled;
                $scope.isNextDisabled = $scope.currentPage.isNextDisabled;
            }
        };
        $scope.nextPage = function () {
            if (!($scope.configPageIndex >= $scope.configPages.length)) {
                $scope.currentPage.isActive = false;
                // if we're able to nav away, have to assume page data is valid
                //$scope.currentPage.isValid = true;
                $scope.configPageIndex++;
                $scope.currentPage = $scope.configPages[$scope.configPageIndex];
                $scope.changeLocation($scope.currentPage.routeName);
                $scope.currentPage.isActive = true;
                $scope.configValues = $scope.currentPage.configValues;
                $scope.isPreviousDisabled = $scope.currentPage.isPreviousDisabled;
                $scope.isNextDisabled = $scope.currentPage.isNextDisabled;
            }
        };

        $scope.percentComplete = 0;

    }
])