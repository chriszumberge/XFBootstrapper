"use strict";
angular.module('app').config(['$routeProvider', function ($routeProvider) {
    var routes = [
        {
            url: '/start',
            config: {
                templateUrl: 'app/templates/start_here.html'
                //template: '<h1>Home</h1>'
                //templateUrl: 'app/templates/home.html',
                //controller: 'homeController',
                // optional map of dependencies to be injected into the controller
                //resolve: {
                //    viewTitle: function () { return "Home"; }
                //}
            }
        },
        {
            url: '/type',
            config: {
                templateUrl: 'app/templates/project_type.html'
            }
        },
        {
            url: '/mobileplatform',
            config: {
                templateUrl: 'app/templates/mobile_platform.html'
            }
        },
        {
            url: '/features',
            config: {
                templateUrl: 'app/templates/features.html'
            }
        },
        {
            url: '/configure',
            config: {
                templateUrl: 'app/templates/configure.html'
            }
        },
        {
            url: '/advanced',
            config: {
                templateUrl: 'app/templates/advanced.html'
            }
        },
        {
            url: '/download',
            config: {
                templateUrl: 'app/templates/download.html'
            }
        }
    ];

    routes.forEach(function (route) {
        $routeProvider.when(route.url, route.config);
    });

    $routeProvider.otherwise({ redirectTo: '/start' });
}]);