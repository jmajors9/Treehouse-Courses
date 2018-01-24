# Loops: for and while

my_list = ['hello', 'how', 'are', 'you']
for word in my_list:
    print(word)

for letter in 'abcdefghijklmnopqrstuvwxyz':
    print(letter.upper())

for num in [1,2,3,4]:
    if num % 2 == 0:
        print(num)

# while this thing is true, do this stuff

start = 10
while start:
    # truthy start
    print(start)
    start -=1


# sometimes your loop needs to end early? don't want anything infinite!
names = ["joel", "jen", "james", "QUIT", "naomi"]
for name in names:
    if name == 'QUIT':
        break
        print(name)

# what about skipping an item?
for name in names:
    if name == 'QUIT':
        continue
    print(name)
