function GetChallengesFromApi() {
    REST_Get('challenges', ReadChallengesFromApiAsync);
}

function ReadChallengesFromApiAsync() {
    var data = JSON.parse(this.response);

    data.forEach(challenge => {
        // Log each movie's title
        console.log(challenge.Theme);
    });
}