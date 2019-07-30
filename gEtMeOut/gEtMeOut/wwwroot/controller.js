var app = angular.module("mainApp", ["ngRoute"]);

var serviceBase = location.protocol + "//" + location.hostname + (location.port ? ":" + location.port : "") + location.pathname;
if (serviceBase.substr(-1) !== '/') {
    serviceBase += '/';
}

app.constant("backendConfig", {
    url: serviceBase
});

app.config(function ($routeProvider) {
    $routeProvider
        .when("/", {
            templateUrl: "./Main/Main.html"
        });
});