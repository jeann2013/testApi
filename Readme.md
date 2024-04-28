Primero debe de ejecutar el servicio que esta en este directorio JWTAuthentication\JWTAuthentication\bin\Release\netcoreapp2.1\win-x64\JWTAuthentication.exe

Segundo 

Pueden probar el login
Post para generar Key desde login

`curl --location 'http://localhost:5000/api/login' \
--header 'Content-Type: application/json' \
--data '{"username": "Jignesh", "password": "password"}'`


Get del api `https://jsonplaceholder.typicode.com/todos`

`curl --location 'http://localhost:5000/api/values' \
--header 'Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJKaWduZXNoIFRyaXZlZGkiLCJlbWFpbCI6InRlc3QuYnRlc3RAZ21haWwuY29tIiwiRGF0ZU9mSm9pbmciOiIyMDEwLTA4LTAyIiwianRpIjoiN2NlNjkxYjItMWU4ZS00NTRmLTk0ZTAtOTliMzFhN2ZkZTA2IiwiZXhwIjoxNzE0Mjg5NjI2LCJpc3MiOiJUZXN0LmNvbSIsImF1ZCI6IlRlc3QuY29tIn0.IDa738F_zkSRxIOT1EZe_6zZ1EOXQCGtNo-EVcoSG8c' \
--header 'Content-Type: application/x-www-form-urlencoded'`

Post para enviar datos

`curl --location 'http://localhost:5000/api/data' \
--header 'Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJKaWduZXNoIFRyaXZlZGkiLCJlbWFpbCI6InRlc3QuYnRlc3RAZ21haWwuY29tIiwiRGF0ZU9mSm9pbmciOiIyMDEwLTA4LTAyIiwianRpIjoiZDg2Y2NlOTAtY2Q3NC00ZTJlLWJiYWQtMGU5YjA0OGU3NjZiIiwiZXhwIjoxNzE0MjkyNTAxLCJpc3MiOiJUZXN0LmNvbSIsImF1ZCI6IlRlc3QuY29tIn0.jB2jGUXaCwJR5OdrV3AfukFx8j6g_1ZhHjX3SBXkLvM' \
--header 'Content-Type: application/json' \
--data '{"price": "200.00", "title": "MyFirstBook"}'`