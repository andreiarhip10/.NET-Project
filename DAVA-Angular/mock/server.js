var express = require("express");
var app = express();
var bodyParser = require('body-parser');
var port = 5000;
var router = express.Router();
const api = '/api';
var users = require('./users/getUsers');

app.use(function (req, res, next) {
    res.setHeader("Access-Control-Allow-Origin", "*");
    res.setHeader("Access-Control-Allow-Credentials", "true");
    res.setHeader("Access-Control-Allow-Methods", "GET,HEAD,OPTIONS,POST,PUT");
    res.setHeader("Access-Control-Allow-Headers", "Access-Control-Allow-Headers, Origin,Accept, X-Requested-With, Content-Type, Access-Control-Request-Method, Access-Control-Request-Headers");
    next();
});

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));
app.use(api, router);
app.use(api, users);

router.get('/', function (req, res) {
    res.json({ message: 'Hooray! Welcome to our api!' });
});

app.listen(port, function (err) {
    if (err) {
        console.log(err);
        return;
    }
    console.log("Listening mock server on port " + port);
});