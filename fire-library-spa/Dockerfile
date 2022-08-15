#FROM node:latest as node
#WORKDIR /app

#COPY ./ ./
#RUN npm install
#RUN npm run build --prod

#FROM nginx:alpine
#COPY --from=node /app/dist/fire-library-spa /usr/share/nginx/html

#FROM node:latest as build 

WORKDIR /app
COPY . .
RUN npm install
RUN npm run build 

FROM nginx:latest 

COPY --from=build /app/dist/* /usr/share/nginx/html

EXPOSE 80
