var challengesList; //All challenges found in API

function GetChallengesFromApi() {
    //Calls the GET method from the API. Return will be handled in ReadChallengesFromApiAsync() method.
    REST_Get('challenges', ReadChallengesFromApiAsync);
}

function ReadChallengesFromApiAsync() {

    //Já pega a response do que quer que tenha chamado ele
    challengesList = JSON.parse(this.response);
    
    challengesList.forEach(challenge => {

        var newLine = document.createElement("a");
        newLine.className = "collection-item";
        newLine.style = "cursor: pointer;";
        newLine.href = "ChallengeResults.html";
        newLine.onclick = function () { LoadChallengeInLocalStorage(challenge.id) };

        var lineText = document.createTextNode(challenge.theme);
        newLine.appendChild(lineText);
        document.getElementById("challengeList").appendChild(newLine);
    });
}

function LoadChallengeInLocalStorage(challengeId) {

    //Gets the Id in the clicked element's value
    var challenge = FindChallengeById(challengeId);

    //Loads in local storage
    window.localStorage.setItem(STORAGE_CHALLENGE_ID, challenge.id);
    window.localStorage.setItem(STORAGE_PAGE_TITLE, challenge.theme);
}

function FindChallengeById(Id) {

    //Returns null if there is no challenge list.
    if (!challengesList)
        return null;

    //Iterate over each element in the array
    for (var i = 0; i < challengesList.length; i++) {
        // look for the entry with a matching 'ID' value
        if (challengesList[i].id == Id) {
            return challengesList[i];
        }
    }

    //Returns null if nothing was found
    return null;
}