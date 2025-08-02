# MyFirstMCP

A simple MCP (Model Context Protocol) server to play with silly jokes, built with .NET 8.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Node.js (for the inspector)

### Running the Server

To start the server, run:

```sh
dotnet run --project MyFirstMCP/MyFirstMCP.csproj
```

### Inspecting the MCP Server

To inspect and interact with the MCP server, use the official inspector:

```sh
npx @modelcontextprotocol/inspector
```

This will connect to the running server and allow you to explore its tools and capabilities.

## Features

- Echo tool: echoes messages back to the client.
- Reverse echo tool: returns the reversed message.
- Joke service: provides silly jokes.

##
