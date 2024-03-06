// PubSub module
const PubSub = (function () {
    // Storage for topics/subscribers
    const topics = {};

    // Subscribe to a topic
    async function subscribe(topic, subscriber) {
        if (!topics[topic]) {
            topics[topic] = [];
        }
        topics[topic].push(subscriber);
    }

    // Publish a message to a topic
    async function publish(topic, data) {
        if (topics[topic]) {
            topics[topic].forEach(function (subscriber) {
                subscriber(data);
            });
        }
    }

    // Unsubscribe from a topic
    async function unsubscribe(topic, subscriber) {
        if (topics[topic]) {
            topics[topic] = topics[topic].filter(function (sub) {
                return sub !== subscriber;
            });
        }
    }

    // Expose public methods
    return {
        subscribe: subscribe,
        publish: publish,
        unsubscribe: unsubscribe
    };
})();

// Example usage
async function handleEvent1(data) {
    console.log("Event 1 handled with data:", data);
}

async function handleEvent2(data) {
    console.log("Event 2 handled with data:", data);
}

// Subscribe to events
PubSub.subscribe("event1", handleEvent1);
PubSub.subscribe("event2", handleEvent2);

// Publish events
PubSub.publish("event1", "Hello from Event 1");
PubSub.publish("event2", "Hello from Event 2");

// Unsubscribe from events
PubSub.unsubscribe("event1", handleEvent1);
