// Download the helper library from https://www.twilio.com/docs/node/install
// Your Account Sid and Auth Token from twilio.com/console
// DANGER! This is insecure. See http://twil.io/secure
const accountSid = 'ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX';
const authToken = 'your_auth_token';
const client = require('twilio')(accountSid, authToken);

client.addresses('AD2a0747eba6abf96b7e3c3ff0b4530f6e')
  .dependentPhoneNumbers
  .list({limit: 20})
  .then(dependentPhoneNumbers => dependentPhoneNumbers.forEach(d => console.log(d.sid)));
