# key management
joelamajors = {"first_name": "Joel", "job": "Developer"}

joelamajors["last_name"] = "Majors"

# adds it in
# but this could be cumbersome with multiple values

joelamajors.update({"job": "English Teacher", "editor": "SublimeText3"})
# should add in the business
# but plus signs aren't supported for dicts

joelamajors["editor"] = "any"

# now to delete!

del joelamajors["job"]
