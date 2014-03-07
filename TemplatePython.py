class SortUpDown:

    def sort(self):  pass
    def view(self): pass
    #def eat(self):  pass

#Template method.
    def go(self):
        self.sort()
        self.view()

class SortUp(SortUpDown):
    def __init__(self,a):
        self.a=a

    def sort(self):
        self.a.sort()

    def view(self):
        print "El ordenamiento fue Ascendente: ",self.a

class SortDown(SortUpDown):
    def __init__(self,a):
        self.a=a

    def sort(self):
        self.a.sort(reverse=True)

    def view(self):
        print "El ordenamiento fue Descendente: ",self.a

ar=[-2,2,1,44,2,1,0,0,-4,6,-7,9,33,1,-89]
up = SortUp(ar)
up.go()

print 25*"+"

down=SortDown(ar)
down.go()