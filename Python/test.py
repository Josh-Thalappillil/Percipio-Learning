import re

import re

def find_emails(string):
    pattern = r'\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b'
    return re.findall(pattern, string)


emails = find_emails("Please contact us at jthalappillil@gmail.com, jozjaz7@gmail.com, john@example.com or mary@example.org")
print(emails)  # Output: ['john@example.com', 'mary@example.org']