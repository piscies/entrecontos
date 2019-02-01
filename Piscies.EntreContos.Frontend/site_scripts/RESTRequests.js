var APIServiceBaseAddress = 'http://localhost:64741/api/'

function REST_Get(apiPath, jsonDataInterpretationCallback) {

    var request = new XMLHttpRequest();

    // Open a new connection, using the GET request on the URL endpoint
    request.open('GET', APIServiceBaseAddress + apiPath, true);

    //Reads JSON Data
    request.onload = jsonDataInterpretationCallback;

    // Send request
    request.send();
}