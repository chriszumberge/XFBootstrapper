"use strict";
angular.module('app').factory('httpFeaturesService', ['httpServiceBase', function (httpServiceBase) {
    var featuresService = {};

    featuresService.getFeatures = function () {
        return httpServiceBase.httpGet("Features");
    };

    return featuresService;
}]);