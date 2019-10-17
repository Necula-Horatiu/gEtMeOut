(function () {
    'use strict';

    angular.module('mainApp').service('dataContext', ['httpService', function (httpService) {
        var service = {
            getUsers: getUsers,
            getEventsByLocation: getEventsByLocation
        };

        function getUsers() {
            return httpService.get('api/user');
        }

        function getEventsByLocation(id, longitudine, latitudine, interese, km) {
            return httpService.post('api/event/' + km, { Id: id, Longitudine: parseFloat(longitudine), Latitudine: parseFloat(latitudine), Interese: interese });
        }

        return service;
    }]);

})();