var express = require('express');
var router = express.Router();

router.post('/createActivity', function(req, resp) {

    if (req.query.type != 'leisure' && req.query.type !=  'housework' && req.query.type != 'work') {
        resp.status(400);
        resp.json({
            message: "Invalid type."
        })
    }

    if (req.query.name == '') {
        resp.status(400);
        resp.json({
            message: "Name field can't be empty."
        })
    }

    if(req.query.description == '') {
        resp.status(400);
        resp.json({
            message: "Description field can't be empty."
        })
    }

    resp.status(200);
    resp.json([
        {
            type: req.query.type,
            value: [{
                name: req.query.name,
                description: req.query.description,
                startingTime: req.query.startingTime,
                endingTime: req.query.endingTime,
                isFinished: req.query.isFinished
            }],
            message: "Created activity."
        }
    ])
})

module.exports = router;