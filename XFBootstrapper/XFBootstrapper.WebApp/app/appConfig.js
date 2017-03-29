angular.module('app').config(['$httpProvider', function ($httpProvider) {
    //$httpProvider.interceptors.push('authInterceptorService');
}]);

angular.module('app').config(['$mdThemingProvider', function ($mdThemingProvider) {
    $mdThemingProvider.theme('xfbootstrapper')
        .primaryPalette('light-blue')
        .accentPalette('blue-grey')
        .warnPalette('red');

    $mdThemingProvider.alwaysWatchTheme(true);
}]);

angular.module('app').config(['localStorageServiceProvider', function (localStorageServiceProvider) {
    //Set the cookie domain, since this runs inside a the config() block, only providers and constants can be injected. 
    //As a result, $location service can't be used here, use a hardcoded string or window.location.
    //For local testing (when you are testing on localhost) set the domain to an empty string ''. 
    //Setting the domain to 'localhost' will not work on all browsers (eg. Chrome) since some browsers only allow you to set 
    //domain cookies for registry controlled domains, i.e. something ending in .com or so, but not IPs or intranet hostnames like localhost.
    var cookieDomain = '';
    if (window.location.host.indexOf('localhost') < 0) {
        cookieDomain = window.location.host;
    }

    //https://github.com/grevory/angular-local-storage
    localStorageServiceProvider
        //Avoid overwriting any local storage variables from the rest of your app
        .setPrefix('WMB')
        //Set primary option to use local storage
        .setStorageType('localStorage')
        //Cookie options are a fall back if local storage is not supported
        .setStorageCookie(0, '/')
        .setStorageCookieDomain(cookieDomain)
        //Send signals for each of the following actions:
        //setItem
        //removeItem
        .setNotify(true, false);
}]);