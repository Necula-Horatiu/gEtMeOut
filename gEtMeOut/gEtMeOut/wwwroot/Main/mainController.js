(function () {
    'use strict';

    angular.module('mainApp').controller('mainController', ['dataContext', function (dataContext) {
        var vm = this;
        vm.pos = null;

        dataContext.getUsers().then(
            function (response) {
                console.log(response.data);
                console.log('aici');
            },
            function (error) {
                console.log(error);
            }
        );

        if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(function (position) {
                console.log(position);
                vm.pos = position;
            });
        }

        vm.events = function () {
            dataContext.getEventsByLocation("nume", 10, vm.pos.coords.latitude, vm.pos.coords.longitude, "ceva").then(
                function (response) {
                    console.log(response);
                },
                function (error) {
                    console.log(error);
                }
            );
        };
    }]);
})();