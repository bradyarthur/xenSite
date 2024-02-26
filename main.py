from langchain_google_vertexai import VertexAI

model = VertexAI(model_name="gemini-pro", project="abxen-415216")

message = "What are some of the pros and cons of Python as a programming language?"
model.invoke(message)

# Project ID
#abxen-415216