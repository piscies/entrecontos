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

        //Creates the new line in the collection (as avatar)
        var newLine = document.createElement("li");
        newLine.className = "collection-item avatar";

        //Creates the avatar and adds to collection
        var newAvatar = document.createElement("i");
        newAvatar.className = "material-icons circle";
        newAvatar.textContent = "folder";
        
        newLine.appendChild(newAvatar);

        //Creates the short story title and adds to the collection
        var shortStoryNameSpan = document.createElement("span");
        shortStoryNameSpan.className = "title";
        shortStoryNameSpan.textContent = result.shortStory.title;
        
        newLine.appendChild(shortStoryNameSpan);

        //Adds the new line to the list
        document.getElementById("resultsList").appendChild(newLine);
    });
}