# Download the helper library from https://www.twilio.com/docs/python/install
from twilio.rest import Client


# Your Account Sid and Auth Token from twilio.com/console
# DANGER! This is insecure. See http://twil.io/secure
account_sid = 'ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX'
auth_token = 'your_auth_token'
client = Client(account_sid, auth_token)

short_code = client.messaging \
                   .services('MG2172dd2db502e20dd981ef0d67850e1a') \
                   .short_codes \
                   .create(short_code_sid='SC3f94c94562ac88dccf16f8859a1a8b25')

print(short_code.sid)
