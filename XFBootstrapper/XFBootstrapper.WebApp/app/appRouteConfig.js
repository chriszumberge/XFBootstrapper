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
                template: '<h1>Type</h1><config-page-content></config-page-content>'
            }
        }
    ];

    routes.forEach(function (route) {
        $routeProvider.when(route.url, route.config);
    });

    $routeProvider.otherwise({ redirectTo: '/start' });
}]);