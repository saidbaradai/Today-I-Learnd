### To start mongoDB

```bash
sudo mongod --dbpath ~/data/db
```

### To use port 3000:
 ```bash
 Identify the process that is currently using port 3000

lsof -i :3000


then

kill <PID>

 ```
