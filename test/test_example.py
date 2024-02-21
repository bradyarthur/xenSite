# test_example.py

import pytest
from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC

@pytest.fixture
def browser():
    # Initialize WebDriver
    driver = webdriver.Chrome()
    # Set implicit wait time
    driver.implicitly_wait(10)
    # Pass WebDriver instance to the test function
    yield driver
    # Teardown - close the browser
    driver.quit()

def test_google_search(browser):
    # Open Google website
    browser.get("https://www.google.com")
    # Find the search input field
    search_input = browser.find_element(By.NAME, "q")
    # Type the search query
    search_input.send_keys("pytest-selenium example")
    # Submit the search
    search_input.submit()
    # Wait for search results to load
    WebDriverWait(browser, 10).until(EC.title_contains("pytest-selenium example"))
    # Assert the title of the search results page
    assert "pytest-selenium example" in browser.title
