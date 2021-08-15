 # Poc

 ## Kafka + Debezium 

 #### This is a proof of concept of how kafka works together with debezium to create a connection to SQL Server and automatically create topics from changes made directly to the database. 

\
&nbsp;



 ### Steps
- Edit the docker-compose.yml file inside the scripts folder and change the ip 192.168.0.73:9092 to your local IP, example: 000.000.0.00:9092.
- Run the docker-compose up command inside the scripts folder.
- Run the script.sql file from within the scripts folder.
- Import the file into postman and make a post to write the data from your created database to the debezium connector, remember to change the host to your local ip, If you prefer, you can consult the endpoint [documentation](https://docs.confluent.io/debezium-connect-sqlserver-source/current/index.html).
- Open the solution and change line 15 of App.Consumer to your local ip as specified in the first step and run App.Consumer.
 - Add a record to the table for debezium to create a topic.


############################################################################## 

\
&nbsp;
## Remember that the code is a POC (proof of concept).