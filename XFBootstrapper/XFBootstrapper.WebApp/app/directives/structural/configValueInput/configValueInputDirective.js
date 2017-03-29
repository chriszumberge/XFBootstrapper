"use strict;"

angular.module('app').directive('configValueInput', [function () {
    return {
        scope: {
            label: '@?',
            required: '=?',
            configModel: '=',
            ngChangeHandler: '=?',
            minLength: '=?'
        },
        transclude: false,
        replace: true,
        restrict: 'E',
        templateUrl: 'app/directives/structural/configValueInput/configValueInputTemplate.html',
        link: function (scope, el, attrs) {
            if (scope.minLength === undefined) {
                scope.minLength = 0;
            }
            if (scope.required === undefined) {
                scope.required = false;
            }
        },
        controller: function ($scope) {
        }
    }
}]);