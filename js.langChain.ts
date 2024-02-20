import { OpenAI, ChatOpenAI } from "@langchain/openai";

const openAIApiKey = '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';

const chatModel = new ChatOpenAI({
    openAIApiKey
});
