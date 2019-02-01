var APIServiceBaseAddress = 'http://localhost:64741/api/'

function REST_Get(apiPath, jsonDataInterpretationCallback) {

    var request = new XMLHttpRequest();

    // Open a new connection, using the GET request on the URL endpoint
    request.open('GET', APIServiceBaseAddress + apiPath, true);

    //Reads JSON Data
    request.onload = function () {
        var data = JSON.parse(this.response);

        data.forEach(movie => {
            // Log each movie's title
            console.log(movie.title);
        });
    }    

    // Send request
    request.send();
}