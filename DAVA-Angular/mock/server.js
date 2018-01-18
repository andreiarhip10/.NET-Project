var express = require("express");
var app = express();
var bodyParser = require('body-parser');
var port = 5000;
var router = express.Router();
const api = '/api';
var users = require('./users/getUsers');
var user = require('./users/getUser');
var createUser = require('./users/createUser');
var activities = require('./activities/getActivities');
var activity = require('./activities/getActivity');
var createActivity = require('./activities/createActivity');

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
app.use(api, user);
app.use(api, createUser);
app.use(api, activities);
app.use(api, activity);
app.use(api, createActivity);

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