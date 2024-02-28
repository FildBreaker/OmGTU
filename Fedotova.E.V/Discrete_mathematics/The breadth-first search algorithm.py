from collections import deque

class Graph:
    def __init__(self, vertices):
        self.V = vertices
        self.adjList = [[] for _ in range(vertices + 1)]

    def addEdge(self, u, v):
        self.adjList[u].append(v)
        self.adjList[v].append(u)

    def BFS(self, start):
        visited = [False] * (self.V + 1)
        queue = deque()

        queue.append(start)
        visited[start] = True

        while queue:
            current = queue.popleft()
            print(current, end=' ')

            for neighbor in self.adjList[current]:
                if not visited[neighbor]:
                    queue.append(neighbor)
                    visited[neighbor] = True

    def findConnectedComponents(self):
        visited = [False] * (self.V + 1)

        for v in range(1, self.V + 1):  # Обходим от 1 до self.V включительно
            if not visited[v]:
                self.BFS(v)
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
