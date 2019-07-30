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

        function getEventsByLocation(nume, varsta, longitudine, latitudine, interese) {
            return httpService.post('api/event/3', { Nume: "horatiu", Varsta: 10, Longitudine: parseFloat(longitudine), Latitudine: parseFloat(latitudine), Interese: interese });
        }

        return service;
    }]);

})();