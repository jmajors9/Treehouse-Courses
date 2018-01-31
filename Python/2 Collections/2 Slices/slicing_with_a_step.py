numbers = list(range(20))

# [0-19]. gives a range object, but made a list by list

[0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19]

numbers[::2]
# gives the even nos : = start, : = stop, : = step
# default step is one

"Oklahoma"[::2]
"olhm"

numbers[-2:]
[18, 19]

numbers[-2:-5]
[]

numbers[-2:-5:-1]
[18, 17, 16]

numbers[::-1]
# reverses the list
