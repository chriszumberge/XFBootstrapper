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

        $scope.project;

        if ($scope.project === undefined) {
            // Initailize the project
            $scope.project = {};
            // Set the location to the start
            $location.path("start");
        }

        $scope.sanitizeProjectName = function () {
            if ($scope.project.name) {
                $scope.project.name = $scope.project.name.replace(" ", "_").replace(/[^a-zA-Z0-9._-]/g, '');
            }
        };

        $scope.percentComplete = 0;
        $scope.thisStepCompletionValue = 50;


    }
])