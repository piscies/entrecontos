//Loads data from Local Storage
var challengeId = window.localStorage.getItem(STORAGE_CHALLENGE_ID);
var challengeTitle = window.localStorage.getItem(STORAGE_PAGE_TITLE);

//Loads results from API
GetChallengeResultsFromApi(challengeId);

function GetChallengeResultsFromApi(challengeId) {
    REST_Get('challenges/' + challengeId, ReadChallengeResultsFromApiAsync);
}

function ReadChallengeResultsFromApiAsync() {
    //Já pega a response do que quer que tenha chamado ele
    var data = JSON.parse(this.response);

    data.classification.forEach(result => {

        var newLine = document.createElement("a");
        newLine.className = "collection-item";

        var lineText = document.createTextNode(result.shortStory.title);
        newLine.appendChild(lineText);
        document.getElementById("resultsList").appendChild(newLine);
    });
}