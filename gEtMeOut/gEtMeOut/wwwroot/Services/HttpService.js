(function () {
    'use strict'

    angular.module('mainApp').service('httpService', ['$http', '$q', 'backendConfig', function ($http, $q, backendConfig) {
        var service = {
            get: get,
            post: post
        };

        function get(path) {
            var deferred = $q.defer();

            $http.get(backendConfig.url + path).then(
                function (response) {
                    deferred.resolve(response);
                },
                function (err, status) {
                    deferred.reject(err);
                }
            );

            return deferred.promise;
        }

        function post(path, data) {
            var deferred = $q.defer();

            $http.post(backendConfig.url + path, data).then(
                function (response) {
                    deferred.resolve(response);
                },
                function (err, status) {
                    deferred.reject(err);
                }
            );

            return deferred.promise;
        }
        return service;
    }]);
})();