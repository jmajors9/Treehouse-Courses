# indexes begin at 0
# can index from the end using negative nos
>>> alpha = 'abcde'
>>> alpha.index('a')
0
>>> 'abcabc'.index('a')
0
alpha_list = list(alpha)
alpha_list.index('b')
1
alpha_list.index('cd')
2
alpha_list.index('ce')
error

alpha[0]
a

alpha_list[2]
'c'
