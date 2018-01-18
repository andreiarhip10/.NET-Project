var express = require('express');
var router = express.Router();

router.post('/createUser', function(req, resp) {

if(req.query.username == '') {
    resp.status(400);
    resp.json({
        message: "Username is required."
    })
}

if(req.query.password.length < 8){
    resp.status(400);
    resp.json({
        message: "Password is too short."
    })
}

if(req.query.email == ''){
    resp.status(400);
    resp.json({
        message: "Email is required."
    })
}

resp.status(200);
    resp.json([
        {
            value: [{
                username: req.query.username,
                password: req.query.password,
                email: req.query.email
            }],
            message: "Created user."
        }
    ]);
})

module.exports = router;