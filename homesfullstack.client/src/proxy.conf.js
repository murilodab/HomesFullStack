const PROXY_CONFIG = [
  {
    context: [
      "/homesfullstack",
    ],
    target: "https://localhost:7119",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
