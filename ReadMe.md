Initial Steps
=============
Update the launchSettings.json files to disable IIS and run as a console app.
Remove the route in the weather api controller.
Decorate the weather api method with desired method name.

The Dapr service endpoint format
================================
http://localhost:<dapr-http-port>/v1.0/invoke/<app-id>/method/<method-name>

Weather API
===========
dapr run --app-id weatherapi --app-port 5001 --dapr-http-port 50001 dotnet run
http://localhost:50001/v1.0/invoke/weatherapi/method/weatherforecast
Invoke-RestMethod -Method Get -Uri 'http://localhost:50001/v1.0/invoke/weatherapi/method/weatherforecast'

Weather App
===========
dapr run --app-id frontend --app-port 5002 --dapr-http-port 50002 dotnet run
http://localhost:5002

Dapr & Zipkin dashboards
========================
Run the following command and get the URL and open on browser.
dapr dashboard
http://localhost:8080/overview

Run => docker ps to reveal Zipkin port.
http://localhost:9411/zipkin/
