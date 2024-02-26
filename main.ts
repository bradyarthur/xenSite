import { OpenAI, ChatOpenAI } from "@langchain/openai";
const openAIApiKey = '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';

const chatModel = new ChatOpenAI({
    openAIApiKey
});

// Goog API key
// AIzaSyC7RhCi7eNtjFStq-vM_6YL-l7j7onAlrc

await chatModel.invoke("what is LangSmith?");

console.log('ABX');