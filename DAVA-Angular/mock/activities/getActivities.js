var express = require('express');
var router = express.Router();

router.get('/getActivities', function (req, resp) {
    var activitiesArray = ["Read a book", "Random Activity",
        "Study ComputerScience", "Learn Chess", "Play Guiyar",
        "Learn .NET", "Study Machine Learning", "Start a company", "Ride a bike", "Start learning Javascript", "Use sql"];
    var firstActivity = activitiesArray[Math.floor((Math.random() * 7) + 2)];
    var secondActivity = activitiesArray[Math.floor((Math.random() * 7) + 2)];
    var thirdActivity = activitiesArray[Math.floor((Math.random() * 7) + 2)];
    var fourthActivity = activitiesArray[Math.floor((Math.random() * 7) + 2)];
    var fifthActivity = activitiesArray[Math.floor((Math.random() * 7 )+ 2)];


    const user = req.query.username;

    if (user == 'admin') {
        resp.status(200);
        resp.json([
            {
                type: 'Leisure',
                value: [{
                    id: 23,
                    name: firstActivity,
                    description: 'desc',
                    startingTime: '18.01.2018 08:00:00',
                    edingTime: '18.01.2018 08:00:00',
                    isFinished: false
                }, {
                    id: 35,
                    name: secondActivity,
                    description: 'desc',
                    startingTime: '18.01.2018',
                    edingTime: '18.01.2018',
                    isFinished: false
                }]
            },
            {
                type: 'Work',
                value: [{
                    id: 1,
                    name: fourthActivity,
                    description: 'desc',
                    startingTime: '18.01.2018 08:00:00',
                    edingTime: '18.01.2018 08:00:00',
                    isFinished: false
                }, {
                    id: 5,
                    name: 'fourth',
                    description: 'desc',
                    startingTime: '18.01.2018',
                    edingTime: '18.01.2018',
                    isFinished: false
                }]
            },
            {
                type: 'Housework',
                value: [{
                    id: 122,
                    name: 'sec',
                    description: 'desc',
                    startingTime: '18.01.2018 08:00:00',
                    edingTime: '18.01.2018 08:00:00',
                    isFinished: false
                }, {
                    id: 51,
                    name: '4th',
                    description: 'desc',
                    startingTime: '18.01.2018',
                    edingTime: '18.01.2018',
                    isFinished: false
                }]
            }
        ])
    } else {
        if (user == 'dan') {
            resp.status(400);
            resp.json({
                message: "User not found."
            });
        }
    }

});

module.exports = router;