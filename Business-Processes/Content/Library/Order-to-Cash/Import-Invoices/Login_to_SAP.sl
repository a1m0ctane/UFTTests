namespace: Order-to-Cash.Import-Invoices
operation:
  name: Login_to_SAP
  outputs:
  - return_result: ${return_result}
  - error_message: ${error_message}
  sequential_action:
    gav: com.microfocus.seq:Order-to-Cash.Import-Invoices.Login_to_SAP:1.0.0
    steps:
    - step:
        id: '1'
        object_path: Browser("RPA Workflow Designer").Page("RPA Workflow Designer")
        action: Sync
    - step:
        id: '2'
        object_path: Browser("RPA Workflow Designer")
        action: OpenNewTab
        snapshot: .\Snapshots\ssf1.png
        highlight_id: '67778'
    - step:
        id: '3'
        object_path: Browser("Browser")
        action: Navigate
        default_args: '"http://demoaut.com/"'
        snapshot: .\Snapshots\ssf2.png
        highlight_id: '67778'
    - step:
        id: '4'
        object_path: 'Browser("Browser").Page("Welcome: Mercury Tours").WebEdit("userName")'
        action: Set
        default_args: '"amir"'
        snapshot: .\Snapshots\ssf3.html
        highlight_id: '10000000'
    - step:
        id: '5'
        object_path: 'Browser("Browser").Page("Welcome: Mercury Tours").WebEdit("password")'
        action: SetSecure
        default_args: '"amir"'
        snapshot: .\Snapshots\ssf4.html
        highlight_id: '10000000'
    - step:
        id: '6'
        object_path: 'Browser("Browser").Page("Welcome: Mercury Tours").Image("Sign-In")'
        action: Click
        default_args: 14,9
        snapshot: .\Snapshots\ssf5.html
        highlight_id: '10000000'
  results:
  - SUCCESS
  - WARNING
  - FAILURE
