(function () {
    'use strict';

    angular.module('mainApp').controller('concertsController', ['dataContext', function (dataContext) {
        var vm = this;
        vm.concerte = null;
        vm.pos = null;

        if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(function (position) {
                vm.pos = position;
                dataContext.getEventsByLocation(1, vm.pos.coords.latitude, vm.pos.coords.longitude, "rock", 3).then(
                    function (response) {
                        console.log(response.data);
                        vm.concerte = response.data;
                    }, function (err) {
                        console.log(err);
                    }
                );
            });
        }


        /*
        console.log("concertsController");
        window.onload = e => {
            var slider = document.getElementById("distanceSlider");
            var value = document.getElementById("distanceValue");
            value.innerHTML = slider.value + " km";

            slider.oninput = e => {
                value.innerHTML = slider.value + " km";
            };

            var concerts = document.getElementsByClassName("concert-panel");

            console.log(concerts);

            for (var i = 0; i < concerts.length; i++) {
                concerts[i].onmouseover = e => {
                    var concertPanel = e.currentTarget;
                    var concertInfo = concertPanel.getElementsByClassName("concert-panel-info")[0];
                    concertInfo.classList.add("fade-in-bottom");
                    concertInfo.classList.remove("fade-out-bottom");
                };

                concerts[i].onmouseout = e => {
                    var concertPanel = e.currentTarget;
                    var concertInfo = concertPanel.getElementsByClassName("concert-panel-info")[0];
                    concertInfo.classList.add("fade-out-bottom");
                    concertInfo.classList.remove("fade-in-bottom");
                };
            }
        };*/

    }]);
})();


