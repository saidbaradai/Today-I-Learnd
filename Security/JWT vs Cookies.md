## Session Cookie based approach:

1. Server generates a "sessionId" (signs it using "secret key"), and 
(a) saves the sessionId in a sessionDB, and 
(b) sends a cookie with the sessionId to the browser (client side).
2. The browser (client side) receives the "cookie" in the response from server, and saves it in the "cookie" storage. 
3. The browser then includes the "cookie" within every subsequent request to the server.



## JWT JSON Web Token approach:

1. Server generates an "accessToken", encrypting the "userId" and "expiresIn", with the ACCESS_TOKEN_SECRET, 
and sends the "accessToken" to the browser (client side).
2. The browser (client side) receives the "accessToken" and saves it on the client side.
3. The "accessToken" is included in every subsequent request to the server.

[Source](https://medium.com/@prashantramnyc/difference-between-session-cookies-vs-jwt-json-web-tokens-for-session-management-4be67d2f066e#:~:text=The%20JWT%20tokens%20are%20sometimes,by%20the%20%E2%80%9Csecret%20key%E2%80%9D.)
