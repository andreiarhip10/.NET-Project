var express = require('express');
var router = express.Router();

router.get('/getUsers', function (req, resp) {
    const users = [{
        username : 'admin',
        age : 17,
        city: 'Iasi'
    }, {
        username: 'user',
        age: 42,
        city : 'Brasov'
    }]
    resp.status(200);
    resp.json(users);
});

module.exports = router ;
