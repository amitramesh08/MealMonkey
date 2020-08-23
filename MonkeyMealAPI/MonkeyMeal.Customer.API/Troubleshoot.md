https://www.codeproject.com/Questions/740807/Access-denied-for-user-root-localhost-using-pass-2

You have attempted to access the mysql database using root username but with empty or wrong password. Find out the valid username and password for that database and correct them in your connection string accordingly.
BTW, you should not use root account to access your database, you should create a separate user account with limited privileges for that database. Read this: create-a-mysql-database-username-password-and-permissions-from-the-command-line[^].