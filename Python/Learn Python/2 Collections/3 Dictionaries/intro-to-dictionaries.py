course = {"title": "Python Collections"}
course
{"title": "Python Collections"}

course["title"]
"Python Collections"

# another method for creating dict
dict([["name", "kenneth"]])
{"name": "kenneth"}
# not as simple

course = {"title": "Python Collections",
          "teacher": "Kenneth Love",
          "videos": 22}

course["videos"]
22

course["runtime"]
KeyError

# you can nest dictionaries, too
course = {"title": "Python Collections",
          "teacher": {"first_name": "Kenneth Love",
                      "last_name": "Love"},
          "videos": 22}
