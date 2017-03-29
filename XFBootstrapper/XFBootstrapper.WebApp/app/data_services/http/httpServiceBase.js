angular.module('app').factory("httpServiceBase", ["$http", "$q", "$location", "Const_WebApiServiceBase", function ($http, $q, $location, Const_WebApiServiceBase) {
    var _serviceBaseUrl = "";

    if (Const_WebApiServiceBase === "") {
        _serviceBaseUrl = $location.protocol() + '://' + $location.host() + '/';
    }
    else {
        _serviceBaseUrl = Const_WebApiServiceBase;
    }

    var _httpGetRemote = function (url) {
        var deferred = $q.defer();
        $http.get(url, { timeout: deferred.promise })
            .then(function (result) {
                deferred.resolve(result);
            },
            function () {
                deferred.reject();
            });

        deferred.promise.cancel = function (reason) {
            deferred.reject({ reason: reason });
        };

        return deferred.promise;
    };

    var _httpGet = function (serviceMethodUrl) {
        var deferred = $q.defer();
        $http.get(_serviceBaseUrl + serviceMethodUrl, { timeout: deferred.promise })
          .then(function (result) {
              deferred.resolve(result);
          },
          function () {
              deferred.reject();
          });

        // TODO, return deferred object instead of promise.. will need to update ALL calls to
        // access the promise property before calling .then(...)
        deferred.promise.cancel = function (reason) {
            deferred.reject({ reason: reason });
        };

        return deferred.promise;
    };

    var _httpPost = function (serviceMethodUrl, postObject) {
        var deferred = $q.defer();
        $http.post(_serviceBaseUrl + serviceMethodUrl, postObject)
          .then(function (result) {
              deferred.resolve(result);
          },
          function () {
              deferred.reject();
          });

        // TODO, return deferred object instead of promise.. will need to update ALL calls to
        // access the promise property before calling .then(...)
        deferred.promise.cancel = function (reason) {
            deferred.reject({ reason: reason });
        };

        return deferred.promise;
    };

    return {
        httpGetRemote: _httpGetRemote,
        httpGet: _httpGet,
        httpPost: _httpPost
    };
}]);