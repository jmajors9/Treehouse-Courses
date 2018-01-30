# can hold all sort of content
# quote marks have to match, of course

'He\'s right'
"""He's right"""
'''He's right'''

str(5)

'Hello' + "there"
'Hellothere'

'Hello ' + "there"
'Hello there'

# can't add strings to other things. can't subtract strings.

'a' + str(5)
'a5'
'=' * 20
'===================='

status_message = "hey, we have 8 people using the site right now"
status_message = "hey, we have {} people using the site right now"
print(status_message)
hey, we have {} people using the site right now
print(status_message.format(7))
