# Backend for AI Chat Application

This repository contains the backend code for the AI Chat Application, built with C# 

## Features

- Real-time messaging
- REST API for message handling
- Integration with AI services

## Installation

1. Clone the repository
2. Navigate to the project directory
3. Install dependencies: 
    - Ensure you have .NET SDK installed. You can download it from [here](https://dotnet.microsoft.com/download).
    - Install the necessary packages using the following command:
      ```bash
      dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson
      dotnet add package OpenAI-API-dotnet
      ```
4. Start the server: `dotnet run`

## Usage

The backend can be accessed via RESTful endpoints:

- Send message: `POST /Chat`


## Contributing

Contributions are welcome. Please follow the [contribution guidelines](link to contribution guidelines).

## License

This project is licensed under the [MIT License](LICENSE.md).
