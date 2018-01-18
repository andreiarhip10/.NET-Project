var express = require('express');
var router = express.Router();

router.get('/getUsers', function (req, resp) {
    const users = [{
        username : 'admin',
        password : 'adminpas',
        email: 'admin@yahoo.com'
    }, {
        username: 'user',
        password: 'userpas',
        email : 'user@yahoo.com'
    }]
    resp.status(200);
    resp.json(users);
});

module.exports = router;
