(function () {
    'use strict';

    angular.module('mainApp').controller('concertsController', ['dataContext', function (dataContext) {
        var vm = this;
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
        };
    }]);
})();


