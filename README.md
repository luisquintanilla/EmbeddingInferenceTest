# Embedding Inference Test

Use HF Text Inference for embedding generation.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)

## Quick start

1. Download the [data](https://huggingface.co/datasets/Cohere/wikipedia-2023-11-embed-multilingual-v3/blob/main/en/0000.parquet) and save it to the *EmbeddingInferenceTest/data* directory.
1. Start HuggingFace Text Embedding Inference container

    ```bash
    docker run -p 8080:80 --pull always ghcr.io/huggingface/text-embeddings-inference:cpu-1.1 --model-id BAAI/bge-large-en-v1.5
    ```

    This will take a few minutes. Wait until the output says it's ready. Something like:

    ```text
    2024-03-20T20:39:44.955571Z  INFO text_embeddings_router: router/src/lib.rs:263: Ready
    ```

1. Navigate to the *EmbeddingInferenceTest* directory and run the app.

    ```bash
    dotnet run
    ```

## Data Source

[Cohere Wikipedia Multilingual v3](https://huggingface.co/datasets/Cohere/wikipedia-2023-11-embed-multilingual-v3)

## Models

[HuggingFace Text Embeddings Inference](https://github.com/huggingface/text-embeddings-inference)

## Elapsed Time

| # of passages | Estimated time elapsed (seconds) |
| --- | --- |
| 10 | 2 |
| 100 | 22 |
| 1000 | 241 |
