# HTTP GET or POST requester #

![http://www.tomthorpe.co.uk/code/screenshots/httprequest/1.jpg](http://www.tomthorpe.co.uk/code/screenshots/httprequest/1.jpg)

While developing a website that involved many HTTP POST requests to an external web service, I found it slow and tedious to keep sending HTTP POST requests via javascript or other methods in order to test the requests and responses of the web service.

To solve this, I wrote an application in C# that allows you to specify the URL to request, then specify a GET or POST request type. If choosing the POST request type, you can enter the POST querystring to send as part of the request (if using GET, just append it to the URL in the usual way).

The application will then send the request and display the response. It will also keep a history of URLs that you have made requests to and automatically suggest these to you to save you having to re-enter them.

If the response is JSON formatted, enable the json checkbox to automatally format the response.