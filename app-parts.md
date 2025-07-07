# Mobile App Development Plan – React Native + .NET + AWS (Startup)

## Project Overview

- **Frontend**: React Native (JavaScript or TypeScript)
- **Backend**: .NET (C#) with Socket.IO
- **Database**: PostgreSQL (AWS RDS)
- **Cloud Platform**: AWS (EC2, RDS, Cognito, SNS, SES, S3)

---

## Build Order

### 1️⃣ Plan & Design

- ✅Define core features: authentication, chat, user profiles, notifications.
- Create wireframes or UI mockups.
- List backend API endpoints.
- ✅Choose AWS services (Cognito, RDS, EC2, SES, SNS, S3).

---

### 2️⃣ Backend + Cloud Setup

> Build this **before UI** so APIs are ready to connect.

#### Backend Tasks

- Set up .NET project (API server)
- Implement user auth (Cognito or custom + JWT)
- Implement Socket.IO (real-time chat)
- Hash passwords using `bcrypt` or PBKDF2
- Connect to PostgreSQL (RDS)
- Create API endpoints (login, register, get/send message)
- Setup email (SES), push (SNS+FCM), file storage (S3)

#### AWS Setup

- EC2 instance for server hosting
- RDS (PostgreSQL)
- Cognito for signup/signin
- SES for email verification
- SNS for push and optional SMS
- S3 for user uploads

---

### 3️⃣ Mobile App UI (React Native)

> Now connect to real APIs from backend

#### Frontend Tasks

- Initialize React Native (Expo or CLI)
- Implement screens:
  - Login / Signup
  - Dashboard / Chat List
  - Chat Room (with socket.io-client)
  - Profile / Settings
- Connect to API using `axios` or `fetch`
- Store JWT securely
- Integrate FCM push notifications
- Upload avatars/images to S3 or backend

---

### 4️⃣ Final Touches & Deployment

- Secure endpoints with JWT
- Add push notification handling in app
- Register app for App Store / Play Store
- Monitor backend via CloudWatch
- Enable HTTPS via ACM / Route 53 (optional)

---

## Summary Timeline

| Step                  | Estimated Duration |
| --------------------- | ------------------ |
| Plan & Design         | 1–2 days           |
| Backend + Cloud Setup | 5–10 days          |
| Mobile App UI         | 5–15 days          |
| Testing & Deployment  | 3–5 days           |

---

## Security Notes

- Use HTTPS (with AWS ACM or nginx + certbot)
- Never store passwords in plain text — always hash
- Verify JWTs in backend
- Limit public access using AWS Security Groups and IAM

---

## Cloud Services Summary

| Feature            | AWS Service      | Free?                          |
| ------------------ | ---------------- | ------------------------------ |
| Server Hosting     | EC2              | Free for 12 mo (t2.micro)      |
| Database           | RDS (PostgreSQL) | Free for 12 mo 　　            |
| Auth               | Cognito          | Free up to 50,000 MAUs 　　    |
| Email              | SES              | 62k emails/mo via EC2 　　     |
| Push Notifications | SNS + FCM        | SNS free for 1M publishes 　　 |
| File Storage       | S3               | Free 5GB 　　                  |
| Monitoring         | CloudWatch       | Free 5GB logs 　　             |

---

## 💬 Need Help?

Ask for:

- Backend starter code (C# + JWT + RDS)
- React Native starter with auth + chat
- AWS setup guide (EC2, RDS, SES, etc.)
- Architecture diagram
