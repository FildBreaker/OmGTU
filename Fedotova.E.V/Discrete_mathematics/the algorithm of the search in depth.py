class Graph:
    def __init__(self, vertices):  
        self.V = vertices #Количество вершин
        self.adjList = [[] for _ in range(vertices + 1)]  # Увеличиваем размер списка на 1 для учёта вершин с 1 по vertices

    def addEdge(self, u, v): #Метод для добавления ребра между вершинами u / v и наоборот т.к. граф неориннтированный
        self.adjList[u].append(v)
        self.adjList[v].append(u)

    def DFSUtil(self, v, visited): #Метод для рекурсивного обхода графа в глубину, начиная с вершины v. Помечает вершину как посещённую,выводит её и вызывает себя для всех смежных непосещённых вершин.
        visited[v] = True
        print(v, end='')

        for i in self.adjList[v]:
            if not visited[i]:
                self.DFSUtil(i, visited)

    def findConnectedComponents(self): #Метод для обхода графа по всем вершинам и нахождения компонента связанности. Для каждой непосещённой вершины вызывается DFSUtil
        visited = [False] * (self.V + 1)  

        for v in range(1, self.V):  # Обходим от 1 до self.V включительно
            if not visited[v]:
                self.DFSUtil(v, visited)
                print()

V = int(input("Введите кол-во вершин: "))
graph = Graph(V)

print("Введите рёбра (Введите -1 -1 для завершения): ")
while True:
    u,v = map(int, input().strip().split())
    if u == -1 and v == -1:
        break
    graph.addEdge(u, v)

print("Компоненты связанности: ")
graph.findConnectedComponents()
