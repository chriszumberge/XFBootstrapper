"use strict;"

angular.module('app').directive('configValueInput', [function () {
    return {
        scope: {
            configModel: '=',
            ngChangeHandler: '=?'
        },
        transclude: false,
        replace: true,
        restrict: 'E',
        templateUrl: 'app/directives/structural/configValueInput/configValueInputTemplate.html',
        link: function (scope, el, attrs) {

        },
        controller: function ($scope) {

        }
    }
}]);