def sillycase(string):
    string_half_length = int(len(string)) / 2
    return string[:string_half_length + 1].upper 
        + string[string_half_length + 1:].lower
